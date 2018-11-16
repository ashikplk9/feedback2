(function() {
  var app;

  app = angular.module('portal', []);

  app.controller('MainCtrl', function($scope) {
    this.tabIndex = 1;
    this.cpanels = [
      {
        name: 'ホスティング 1vCPU/1GB',
        code: '1'
      },
      {
        name: 'ホスティング 2vCPU/4GB',
        code: '2'
      }
    ];
    this.currentCpanel = '1';
  });

}).call(this);

//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiIiwic291cmNlUm9vdCI6IiIsInNvdXJjZXMiOlsiPGFub255bW91cz4iXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7QUFBQSxNQUFBOztFQUFBLEdBQUEsR0FBTSxPQUFPLENBQUMsTUFBUixDQUFlLFFBQWYsRUFBeUIsRUFBekI7O0VBRU4sR0FBRyxDQUFDLFVBQUosQ0FBZSxVQUFmLEVBQTJCLFFBQUEsQ0FBQyxNQUFELENBQUE7SUFDekIsSUFBQyxDQUFBLFFBQUQsR0FBWTtJQUVaLElBQUMsQ0FBQSxPQUFELEdBQVc7TUFDVDtRQUFBLElBQUEsRUFBTSxrQkFBTjtRQUNBLElBQUEsRUFBTTtNQUROLENBRFM7TUFJVDtRQUFBLElBQUEsRUFBTSxrQkFBTjtRQUNBLElBQUEsRUFBTTtNQUROLENBSlM7O0lBT1gsSUFBQyxDQUFBLGFBQUQsR0FBaUI7RUFWUSxDQUEzQjtBQUZBIiwic291cmNlc0NvbnRlbnQiOlsiYXBwID0gYW5ndWxhci5tb2R1bGUgJ3BvcnRhbCcsIFtdXG5cbmFwcC5jb250cm9sbGVyICdNYWluQ3RybCcsICgkc2NvcGUpIC0+XG4gIEB0YWJJbmRleCA9IDFcbiAgXG4gIEBjcGFuZWxzID0gW1xuICAgIG5hbWU6ICfjg5vjgrnjg4bjgqPjg7PjgrAgMXZDUFUvMUdCJ1xuICAgIGNvZGU6ICcxJ1xuICAsICBcbiAgICBuYW1lOiAn44Ob44K544OG44Kj44Oz44KwIDJ2Q1BVLzRHQidcbiAgICBjb2RlOiAnMicgICAgXG4gIF1cbiAgQGN1cnJlbnRDcGFuZWwgPSAnMSdcbiAgcmV0dXJuIl19
//# sourceURL=coffeescript