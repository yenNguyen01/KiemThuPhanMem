from selenium import webdriver
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common.by import By

driver = webdriver.Chrome(executable_path='D:\KTPM\chromedriver.exe')
driver.get("https://www.google.com.vn/")

str = input("Nhap tu khoa")

control = driver.find_element(By.NAME,"q")
control.send_keys(str)
control.submit()

#lay ket qua

results = driver.find_elements(By.CSS_SELECTOR,'div.g')
for kq in results:
    try:
        text = kq.find_element(By.TAG_NAME,'a').text
        link = kq.find_element(By.TAG_NAME,'a').get_attribute('href')

        print(text)
        print(link)
    except NoSuchElementException:
        print('Loi')
driver.close()
