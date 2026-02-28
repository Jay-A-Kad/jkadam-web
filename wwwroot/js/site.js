window.copyEmailText = async function (text, statusId) {
    const status = statusId ? document.getElementById(statusId) : null;
  
    try {
      await navigator.clipboard.writeText(text);
      if (status) {
        status.innerText = "copied to clipboard!";
        setTimeout(() => (status.innerText = ""), 1500);
      }
    } catch (err) {
      // Fallback
      const ta = document.createElement("textarea");
      ta.value = text;
      document.body.appendChild(ta);
      ta.select();
      document.execCommand("copy");
      document.body.removeChild(ta);
  
      if (status) {
        status.innerText = "copied to clipboard!";
        setTimeout(() => (status.innerText = ""), 1500);
      }
    }
  };