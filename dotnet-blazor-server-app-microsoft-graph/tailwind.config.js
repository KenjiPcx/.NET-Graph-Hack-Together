/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./{Pages,Shared}/**/*.{razor,html,cshtml}"],
  theme: {
    extend: {},
  },
    plugins: [require('@tailwindcss/typography'), require("daisyui")],
};
