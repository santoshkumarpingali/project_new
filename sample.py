import os

main_dir = "C:/JENKINS_LATEST"

os.mkdir(main_dir, mode=0o666)
print("Directory '% s' is built!" % main_dir)