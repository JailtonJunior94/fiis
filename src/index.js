const puppeteer = require('puppeteer');

(async () => {
    const browser = await puppeteer.launch();
    const page = await browser.newPage();

    await page.goto('https://www.fundsexplorer.com.br/ranking');

    const fiis = await page.evaluate(() => {
        const tds = Array.from(document.querySelectorAll('table tr td'))
        return tds.map(td => td.innerText)
    });

    console.log('fiis ', fiis)

    for (let i = 0; i < fiis.length; i++) {
        // console.log('for ', fiis[i])
    }

    await browser.close();
})();
