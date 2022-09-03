from selenium import webdriver
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common.by import By

driver = webdriver.Chrome(executable_path='D:\KTPM\chromedriver.exe')
driver.get("https://vnexpress.net/")
print(driver.title)
''' lay cac bai dang'''
acticles = driver.find_elements(By.CSS_SELECTOR,'article.item-news')
for a in acticles:
    try:
        title = a.find_element(By.TAG_NAME,'h3').text
        link = a.find_element(By.CSS_SELECTOR,'h3.title-news>a').get_attribute('href')
        des = a.find_element(By.TAG_NAME,'p').text

        print(title)
        print(link)
        print(des)
    except NoSuchElementException:
        print('loi')
driver.close()