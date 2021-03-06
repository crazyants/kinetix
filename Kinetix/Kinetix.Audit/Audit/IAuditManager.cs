﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Kinetix.Audit
{
    [ServiceContract]
    public interface IAuditManager
    {
        /// <summary>
        /// Add an audit trail.
        /// </summary>
        [OperationContract]
        void AddTrace(AuditTrace auditTrace);

        /// <summary>
        /// Search an audit trail.
        /// </summary>
        /// <param name="auditTraceCriteria">Criteria.</param>
        /// <returns>The matching audit traces.</returns>
        [OperationContract]
        IList<AuditTrace> FindTrace(AuditTraceCriteria auditTraceCriteria);

        /// <summary>
        /// Get an audit trail.
        /// </summary>
        /// <returns>the audit trace for the desired id.</returns>
        [OperationContract]
        AuditTrace GetTrace(int idAuditTrace);
    }
}
