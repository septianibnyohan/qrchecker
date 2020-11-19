function deline(reason) {
  server({
    url: url_decline,
    data: {
      "reason": reason,
      "csrf-token": Cookies.get("CSRF-TOKEN")
    },
    loader: true
  });
}