from selenium import webdriver
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import Select

driver = webdriver.Chrome(executable_path='D:\KTPM\chromedriver.exe')
driver.get("https://www.facebook.com/")
driver.implicitly_wait(10)
try:
    driver.find_element(By.XPATH,"//*[text() = 'Create New Account']").click()
    driver.find_element(By.NAME, 'firstname').send_keys('Nguyen')
    driver.find_element(By.NAME, 'lastname').send_keys('Yen')
    driver.find_element(By.NAME, 'reg_email__').send_keys('yennguyen01012k1@gmail.com')
    driver.find_element(By.NAME, 'reg_email_confirmation__').send_keys('yennguyen01012k1@gmail.com')
    driver.find_element(By.NAME, 'reg_passwd__').send_keys('yen1900')

    day = Select(driver.find_element(By.ID, 'day'))
    day.select_by_visible_text('1')
    month = Select(driver.find_element(By.ID, 'month'))
    month.select_by_visible_text('Jan')
    year = Select(driver.find_element(By.ID, 'year'))
    year.select_by_visible_text('2001')

    driver.find_element(By.XPATH,"//label[text() = 'Female']").click()
    driver.find_element(By.NAME,'websubmit').click()
except NoSuchElementException:
    print('loi')
