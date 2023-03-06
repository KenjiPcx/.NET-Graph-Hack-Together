/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./{Pages,Shared,Toast}/**/*.{razor,html,cshtml}"],
  theme: {
    extend: {},
  },
    plugins: [require('@tailwindcss/typography'), require("daisyui")],
};
