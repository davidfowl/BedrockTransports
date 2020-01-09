﻿namespace Bedrock.Framework.Experimental
{
    public enum KafkaErrorCode : short
    {
        UNKNOWN_SERVER_ERROR = -1, // Retriable: False - The server experienced an unexpected error when processing the request.
        NONE = 0, // Retriable: False
        OFFSET_OUT_OF_RANGE = 1, // Retriable: False - The requested offset is not within the range of offsets maintained by the server.
        CORRUPT_MESSAGE = 2, // Retriable: True -  This message has failed its CRC checksum, exceeds the valid size, has a null key for a compacted topic, or is otherwise corrupt.
        UNKNOWN_TOPIC_OR_PARTITION = 3, // Retriable: True -  This server does not host this topic-partition.
        INVALID_FETCH_SIZE = 4, // Retriable: False - The requested fetch size is invalid.
        LEADER_NOT_AVAILABLE = 5, // Retriable: True -  There is no leader for this topic-partition as we are in the middle of a leadership election.
        NOT_LEADER_FOR_PARTITION = 6, // Retriable: True -  This server is not the leader for that topic-partition.
        REQUEST_TIMED_OUT = 7, // Retriable: True -  The request timed out.
        BROKER_NOT_AVAILABLE = 8, // Retriable: False - The broker is not available.
        REPLICA_NOT_AVAILABLE = 9, // Retriable: False - The replica is not available for the requested topic-partition.
        MESSAGE_TOO_LARGE = 10, // Retriable: False - The request included a message larger than the max message size the server will accept.
        STALE_CONTROLLER_EPOCH = 11, // Retriable: False - The controller moved to another broker.
        OFFSET_METADATA_TOO_LARGE = 12, // Retriable: False - The metadata field of the offset request was too large.
        NETWORK_EXCEPTION = 13, // Retriable: True -  The server disconnected before a response was received.
        COORDINATOR_LOAD_IN_PROGRESS = 14, // Retriable: True -  The coordinator is loading and hence can't process requests.
        COORDINATOR_NOT_AVAILABLE = 15, // Retriable: True -  The coordinator is not available.
        NOT_COORDINATOR = 16, // Retriable: True -  This is not the correct coordinator.
        INVALID_TOPIC_EXCEPTION = 17, // Retriable: False - The request attempted to perform an operation on an invalid topic.
        RECORD_LIST_TOO_LARGE = 18, // Retriable: False - The request included message batch larger than the configured segment size on the server.
        NOT_ENOUGH_REPLICAS = 19, // Retriable: True -  Messages are rejected since there are fewer in-sync replicas than required.
        NOT_ENOUGH_REPLICAS_AFTER_APPEND = 20, // Retriable: True -  Messages are written to the log, but to fewer in-sync replicas than required.
        INVALID_REQUIRED_ACKS = 21, // Retriable: False - Produce request specified an invalid value for required acks.
        ILLEGAL_GENERATION = 22, // Retriable: False - Specified group generation id is not valid.
        INCONSISTENT_GROUP_PROTOCOL = 23, // Retriable: False - The group member's supported protocols are incompatible with those of existing members or first group member tried to join with empty protocol type or empty protocol list.
        INVALID_GROUP_ID = 24, // Retriable: False - The configured groupId is invalid.
        UNKNOWN_MEMBER_ID = 25, // Retriable: False - The coordinator is not aware of this member.
        INVALID_SESSION_TIMEOUT = 26, // Retriable: False - The session timeout is not within the range allowed by the broker (as configured by group.min.session.timeout.ms and group.max.session.timeout.ms).
        REBALANCE_IN_PROGRESS = 27, // Retriable: False - The group is rebalancing, so a rejoin is needed.
        INVALID_COMMIT_OFFSET_SIZE = 28, // Retriable: False - The committing offset data size is not valid.
        TOPIC_AUTHORIZATION_FAILED = 29, // Retriable: False - Topic authorization failed.
        GROUP_AUTHORIZATION_FAILED = 30, // Retriable: False - Group authorization failed.
        CLUSTER_AUTHORIZATION_FAILED = 31, // Retriable: False - Cluster authorization failed.
        INVALID_TIMESTAMP = 32, // Retriable: False - The timestamp of the message is out of acceptable range.
        UNSUPPORTED_SASL_MECHANISM = 33, // Retriable: False - The broker does not support the requested SASL mechanism.
        ILLEGAL_SASL_STATE = 34, // Retriable: False - Request is not valid given the current SASL state.
        UNSUPPORTED_VERSION = 35, // Retriable: False - The version of API is not supported.
        TOPIC_ALREADY_EXISTS = 36, // Retriable: False - Topic with this name already exists.
        INVALID_PARTITIONS = 37, // Retriable: False - Number of partitions is below 1.
        INVALID_REPLICATION_FACTOR = 38, // Retriable: False - Replication factor is below 1 or larger than the number of available brokers.
        INVALID_REPLICA_ASSIGNMENT = 39, // Retriable: False - Replica assignment is invalid.
        INVALID_CONFIG = 40, // Retriable: False - Configuration is invalid.
        NOT_CONTROLLER = 41, // Retriable: True -  This is not the correct controller for this cluster.
        INVALID_REQUEST = 42, // Retriable: False - This most likely occurs because of a request being malformed by the client library or the message was sent to an incompatible broker. See the broker logs for more details.
        UNSUPPORTED_FOR_MESSAGE_FORMAT = 43, // Retriable: False - The message format version on the broker does not support the request.
        POLICY_VIOLATION = 44, // Retriable: False - Request parameters do not satisfy the configured policy.
        OUT_OF_ORDER_SEQUENCE_NUMBER = 45, // Retriable: False - The broker received an out of order sequence number.
        DUPLICATE_SEQUENCE_NUMBER = 46, // Retriable: False - The broker received a duplicate sequence number.
        INVALID_PRODUCER_EPOCH = 47, // Retriable: False - Producer attempted an operation with an old epoch. Either there is a newer producer with the same transactionalId, or the producer's transaction has been expired by the broker.
        INVALID_TXN_STATE = 48, // Retriable: False - The producer attempted a transactional operation in an invalid state.
        INVALID_PRODUCER_ID_MAPPING = 49, // Retriable: False - The producer attempted to use a producer id which is not currently assigned to its transactional id.
        INVALID_TRANSACTION_TIMEOUT = 50, // Retriable: False - The transaction timeout is larger than the maximum value allowed by the broker (as configured by transaction.max.timeout.ms).
        CONCURRENT_TRANSACTIONS = 51, // Retriable: False - The producer attempted to update a transaction while another concurrent operation on the same transaction was ongoing.
        TRANSACTION_COORDINATOR_FENCED = 52, // Retriable: False - Indicates that the transaction coordinator sending a WriteTxnMarker is no longer the current coordinator for a given producer.
        TRANSACTIONAL_ID_AUTHORIZATION_FAILED = 53, // Retriable: False - Transactional Id authorization failed.
        SECURITY_DISABLED = 54, // Retriable: False - Security features are disabled.
        OPERATION_NOT_ATTEMPTED = 55, // Retriable: False - The broker did not attempt to execute this operation. This may happen for batched RPCs where some operations in the batch failed, causing the broker to respond without trying the rest.
        KAFKA_STORAGE_ERROR = 56, // Retriable: True -  Disk error when trying to access log file on the disk.
        LOG_DIR_NOT_FOUND = 57, // Retriable: False - The user-specified log directory is not found in the broker config.
        SASL_AUTHENTICATION_FAILED = 58, // Retriable: False - SASL Authentication failed.
        UNKNOWN_PRODUCER_ID = 59, // Retriable: False - This exception is raised by the broker if it could not locate the producer metadata associated with the producerId in question. This could happen if, for instance, the producer's records were deleted because their retention time had elapsed. Once the last records of the producerId are removed, the producer's metadata is removed from the broker, and future appends by the producer will return this exception.
        REASSIGNMENT_IN_PROGRESS = 60, // Retriable: False - A partition reassignment is in progress.
        DELEGATION_TOKEN_AUTH_DISABLED = 61, // Retriable: False - Delegation Token feature is not enabled.
        DELEGATION_TOKEN_NOT_FOUND = 62, // Retriable: False - Delegation Token is not found on server.
        DELEGATION_TOKEN_OWNER_MISMATCH = 63, // Retriable: False - Specified Principal is not valid Owner/Renewer.
        DELEGATION_TOKEN_REQUEST_NOT_ALLOWED = 64, // Retriable: False - Delegation Token requests are not allowed on PLAINTEXT/1-way SSL channels and on delegation token authenticated channels.
        DELEGATION_TOKEN_AUTHORIZATION_FAILED = 65, // Retriable: False - Delegation Token authorization failed.
        DELEGATION_TOKEN_EXPIRED = 66, // Retriable: False - Delegation Token is expired.
        INVALID_PRINCIPAL_TYPE = 67, // Retriable: False - Supplied principalType is not supported.
        NON_EMPTY_GROUP = 68, // Retriable: False - The group is not empty.
        GROUP_ID_NOT_FOUND = 69, // Retriable: False - The group id does not exist.
        FETCH_SESSION_ID_NOT_FOUND = 70, // Retriable: True -  The fetch session ID was not found.
        INVALID_FETCH_SESSION_EPOCH = 71, // Retriable: True -  The fetch session epoch is invalid.
        LISTENER_NOT_FOUND = 72, // Retriable: True -  There is no listener on the leader broker that matches the listener on which metadata request was processed.
        TOPIC_DELETION_DISABLED = 73, // Retriable: False - Topic deletion is disabled.
        FENCED_LEADER_EPOCH = 74, // Retriable: True -  The leader epoch in the request is older than the epoch on the broker
        UNKNOWN_LEADER_EPOCH = 75, // Retriable: True -  The leader epoch in the request is newer than the epoch on the broker
        UNSUPPORTED_COMPRESSION_TYPE = 76, // Retriable: False - The requesting client does not support the compression type of given partition.
        STALE_BROKER_EPOCH = 77, // Retriable: False - Broker epoch has changed
        OFFSET_NOT_AVAILABLE = 78, // Retriable: True -  The leader high watermark has not caught up from a recent leader election so the offsets cannot be guaranteed to be monotonically increasing
        MEMBER_ID_REQUIRED = 79, // Retriable: False - The group member needs to have a valid member id before actually entering a consumer group
        PREFERRED_LEADER_NOT_AVAILABLE = 80, // Retriable: True -  The preferred leader was not available
        GROUP_MAX_SIZE_REACHED = 81, // Retriable: False - The consumer group has reached its max size.
        FENCED_INSTANCE_ID = 82, // Retriable: False - The broker rejected this static consumer since another consumer with the same group.instance.id has registered with a different member.id.
        ELIGIBLE_LEADERS_NOT_AVAILABLE = 83, // Retriable: True Eligible topic partition leaders are not available
        ELECTION_NOT_NEEDED = 84, // Retriable: True Leader election not needed for topic partition
        NO_REASSIGNMENT_IN_PROGRESS = 85, // Retriable: False No partition reassignment is in progress.
        GROUP_SUBSCRIBED_TO_TOPIC = 86, // Retriable: False - Deleting offsets of a topic is forbidden while the consumer group is actively subscribed to it.
        INVALID_RECORD = 87, // Retriable: False - This record has failed the validation on broker and hence be rejected.
    }
}