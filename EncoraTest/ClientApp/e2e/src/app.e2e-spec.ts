import { AppPage } from './app.po';

describe('App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('should display encora test title', () => {
    page.navigateTo();
    expect(page.getMainHeading()).toEqual('Encora Technical Test for Roofstock');
  });
});
