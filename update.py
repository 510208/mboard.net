import requests
import markdown

def get_repository_info(owner, repo):
    url = f"https://api.github.com/repos/{owner}/{repo}"
    response = requests.get(url)
    data = response.json()
    return data

def get_latest_release_info(owner, repo):
    repository_info = get_repository_info(owner, repo)
    if "releases_url" in repository_info:
        releases_url = repository_info["releases_url"].split("{")[0]
        releases_response = requests.get(releases_url)
        releases_data = releases_response.json()
        if len(releases_data) > 0:
            latest_release = releases_data[0]
            latest_version = latest_release["tag_name"]
            changelog = latest_release["body"]
            return latest_version, changelog
    return None, None

def convert_markdown_to_html(markdown_text):
    return markdown.markdown(markdown_text)

owner = "510208"
repo = "mboard.net"
latest_version, changelog = get_latest_release_info(owner, repo)
# 将Markdown转换为HTML
changelog = convert_markdown_to_html(changelog)

if latest_version and changelog:
    print(latest_version)
    print(changelog)
else:
    print("該儲存庫應該已經移除了版本，檢查該儲存庫是否仍然維護中！")
