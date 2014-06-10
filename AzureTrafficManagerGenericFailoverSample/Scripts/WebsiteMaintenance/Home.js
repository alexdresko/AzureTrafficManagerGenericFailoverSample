var WebsiteMaintenance;
(function (WebsiteMaintenance) {
    var Reload = (function () {
        function Reload() {
        }
        Reload.init = function () {
            var reloadButton = $('#reloadButton');

            window.setTimeout(function () {
                reloadButton.css('visibility', 'visible').hide().fadeIn(1000);
            }, 3000);

            window.setTimeout(function () {
                location.reload(true);
            }, 180000);

            reloadButton.click(function () {
                reloadButton.hide();
            });
        };
        return Reload;
    })();
    WebsiteMaintenance.Reload = Reload;
})(WebsiteMaintenance || (WebsiteMaintenance = {}));

$(function () {
    WebsiteMaintenance.Reload.init();
});
//# sourceMappingURL=Home.js.map
