import { PruebaMarilynMonrroyTemplatePage } from './app.po';

describe('PruebaMarilynMonrroy App', function() {
  let page: PruebaMarilynMonrroyTemplatePage;

  beforeEach(() => {
    page = new PruebaMarilynMonrroyTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
