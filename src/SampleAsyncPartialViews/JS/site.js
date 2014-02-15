/// <reference path="../Scripts/jquery-1.8.2-vsdoc.js" />

var site = site || {};
site.baseUrl = site.baseUrl || "";

$(document).ready(function (e) {
	
	// locate each partial section.
	// if it has a URL set, load the contents into the area.
	
	$(".partialContents").each(function(index, item) {
		var url = site.baseUrl + $(item).data("url");
		if (url && url.length > 0 ) {
			$(item).load(url);
		}
	});
	
	// DEMO ONLY - JUST IGNORE
	// Just to make the loading time obvious....
	$("a.nav").click(function() {
		$("body").html("");
	});
});
