SELECT 
r.session_id AS blocked_session_id,
r.blocking_session_id AS blocking_session_id,
s.login_name,
s.host_name,
st.text AS sql_text
FROM sys.dm_exec_requests r
JOIN sys.dm_exec_sessions s 
ON r.session_id = s.session_id
CROSS APPLY sys.dm_exec_sql_text(r.sql_handle) st
WHERE r.blocking_session_id <> 0;