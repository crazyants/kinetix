﻿SELECT 
	WFW.*
FROM 
	WF_WORKFLOW WFW
WHERE WFW.WFWD_ID = @WFWD_ID 
  AND (WFW.WFS_CODE = 'Sta' OR WFW.WFS_CODE = 'Pau');