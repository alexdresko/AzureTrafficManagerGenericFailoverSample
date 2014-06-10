module WebsiteMaintenance {
    export class Reload {
        public static init() {
            var reloadButton = $('#reloadButton');

            window.setTimeout(() => {
                reloadButton.css('visibility', 'visible').hide().fadeIn(1000);
            }, 3000);

            window.setTimeout(() => {
                location.reload(true);
            }, 180000);

            reloadButton.click(() => {
                reloadButton.hide();
            });
        }
    }
}

$(() => {
    WebsiteMaintenance.Reload.init();
});