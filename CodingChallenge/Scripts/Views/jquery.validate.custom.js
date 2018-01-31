$(document).ready(function () {
    $.validator.methods.date = function (value, element) {
        try {
            var val = value.split('/');
            var day = val[0];
            var month = val[1];
            var year = val[2];
            return this.optional(element) || !/Invalid|NaN/.test(new Date(month + '/' + day + '/' + year).toString());
        }
        catch (e) {
            return false;
        }

    };

    $.validator.methods.number = function (value, element) {
        return this.optional(element) || /^-?(?:\d+|\d{1,3}(?:.\d{3})+)?(?:\,\d+)?$/.test(value);
    };
})
