window.addEventListener("load", function(event)
{
	try
	{
		/*
		if(!document.cookie.includes("reloaded=true"))
		{
			document.cookie = "reloaded=true";
			window.location.reload();
		}
		*/
		const element = document.querySelectorAll("input:not(:focus)")?.[0];
		if(element instanceof HTMLInputElement)
		{
			element.focus({ focusVisible: true });
			const message = `${element.id} is ${document.querySelector(`input#${element.id}:focus`) instanceof HTMLInputElement ? "" : "not"} focused`;
			const span = document.querySelector("span#test-focus-span");
			if(span instanceof HTMLSpanElement)
			{
				span.innerText = message;
			}
			console.log(message);
		}
	}
	catch(e)
	{
		console.error(e);
		throw e;
	}
});
