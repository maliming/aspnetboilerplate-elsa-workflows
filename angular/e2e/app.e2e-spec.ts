import { ElsaProjectTemplatePage } from './app.po';

describe('ElsaProject App', function() {
  let page: ElsaProjectTemplatePage;

  beforeEach(() => {
    page = new ElsaProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
