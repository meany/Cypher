// Cypher (c) by Tangram Inc
// 
// Cypher is licensed under a
// Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
// 
// You should have received a copy of the license along with this
// work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>.

using System;
using LiteDB;
using ProtoBuf;

namespace TangramCypher.Model
{
    [ProtoContract]
    public class MessageDto
    {
        [ProtoMember(1)]
        public string Address { get; set; }
        [ProtoMember(2)]
        public string Body { get; set; }
        [BsonId]
        public Guid TransactionId { get; set; }
    }
}