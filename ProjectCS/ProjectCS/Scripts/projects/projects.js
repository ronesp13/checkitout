$(function () {
    function searchResultTitle(title) {
        $(".search-criteria").text(title);
    }

    function searchResultProjects(projects) {
        console.log(projects);
        var parent = $("div.project-card-list.box");
        parent.empty();
        $.each(projects, function (i, item) {
            parent.append($("<div>")
                .addClass("project-card-list-box col-lg-12 col-md-12 col-sm-12 col-xs-12")
                .append($("<div>")
                    .addClass("project-card box col-xs-12 nopadding")
                    .append($("<img>")
                        .attr("src", item.cover_url)
                        .attr("alt", "Project banner")
                        .addClass("col-xs-12 nopadding")
                        .attr("width", "1200")
                        .attr("height", "300"))
                    .append($("<div>")
                        .addClass("icon-box row")
                        .append($("<div>")
                            .addClass("col-xs-6 nopadding")
                            .append($("<img>")
                                .attr("src", "/Content/images/user.png")
                                .attr("alt", "Something"))
                            .append($("<label>")
                                .addClass("col-xs-12 nopadding")
                                .text(item.followers)))
                        .append($("<div>")
                            .addClass("col-xs-6 nopadding")
                            .append($("<img>")
                                .attr("src", "/Content/images/hearts.png")
                                .attr("alt", "Something"))
                            .append($("<label>")
                                .addClass("col-xs-12 nopadding")
                                .text(item.likes)
                            )))
                    .append($("<div>")
                        .addClass("follow")
                        .append($("<img>")
                            .attr("src", "/Content/images/follow.png")
                            .attr("alt", "Something")))
                    .append($("<div>")
                        .addClass("trans-bg-box col-xs-12")
                        .append($("<h1>")
                            .append($("<a>")
                                .attr("href", "/Projects/Details/" + item.id)
                                .text(item.title))
                        )))
                );
        });
    }

    var search = function () {
        var button = $(this);
        var linkData = {
            value: button.data("search-val"),
            title: button.text()
        }
        var options = {
            url: button.data("href"),
            type: "GET",
            data: linkData
        }
        console.log(options);
        $.ajax(options).done(function (data) {
            searchResultTitle(data["title"]);
            searchResultProjects(data["projects"]);
        });
    };
    $("#title-search").click(search);
    $("#likes-search").click(search);
    $("#follower-search").click(search);
    $("#created-at-search").click(search);
    $("#contributor-search-search").click(search);
});

$(function () {

    var follow = function () {
        var link = $(this);
        var input = {
            __RequestVerificationToken: $("div.follow-project-wrapper > input[type=hidden]").val()
        }
        console.log(input);
        var options = {
            url: link.data("href"),
            type: "POST",
            data: input
        }

        $.ajax(options).done(function (data) {
            alert(data);
        });
    };

    $("#follow-link").click(follow);
});