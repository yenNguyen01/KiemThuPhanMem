from selenium import webdriver
import csv
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import Select

driver = webdriver.Chrome(executable_path='D:\KTPM_0704\chromedriver.exe')
driver.get('https://lms.ou.edu.vn/')


driver.find_element(By.CSS_SELECTOR, '#about a.main-btn').click()
driver.find_element(By.CSS_SELECTOR, 'button.login100-form-btn').click()
userType = Select(driver.find_element(By.NAME,'form-usertype'))
userType.select_by_index(0)

with open('DocFile.csv', 'r', newline='') as f:
    reader = csv.DictReader(f)
    for row in reader:
        user = row['user']
        password = row['password']

tenDangNhap = driver.find_element(By.NAME, 'form-username')
tenDangNhap.send_keys(user)
matKhau = driver.find_element(By.NAME, 'form-password')
matKhau.send_keys(password)

driver.find_element(By.CLASS_NAME, 'm-loginbox-submit-btn').click()

driver.implicitly_wait(4)

# courses = driver.find_element(By.CSS_SELECTOR, 'card-body .dashboard-card .course-info-container .align-items-start .a')
# for c in courses:
#     print(c.text)

driver.close()