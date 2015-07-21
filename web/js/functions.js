function apiCall(args) {
    // args:    object with following fields (all fields are not required)
    //  api:     name of API, for example, 'Players', Undefined by default
    //  method:  func name into API, for example, 'GetAllPlayers', no function be default
    //  data:    object to send to the server
    //  success: success callback (takes 1 arg)
    //  failure: failure callback (may takes 1 arg)

    if (!args)
        args = {};
    if (!args.api)
        args.api = "Unknown";
    if (!args.method)
        args.method = "";
    if (!args.data)
        args.data = {};
    $.ajax({
        method: 'POST',
        url: '/api/' + args.api + '.asmx/' + args.method,
        dataType: 'json',
        data: JSON.stringify(args.data),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (!data || !data.d) {
                if (args.failure)
                    args.failure();
            } else if (args.success)
                args.success(JSON.parse(data.d));
        },
        error: function (msg) {
           if (args.failure)
                args.failure(msg);
        },
    });
}
