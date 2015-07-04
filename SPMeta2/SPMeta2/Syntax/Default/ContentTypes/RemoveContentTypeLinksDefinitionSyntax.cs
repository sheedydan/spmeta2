﻿using System;
using SPMeta2.Definitions;
using SPMeta2.Definitions.ContentTypes;
using SPMeta2.Models;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Syntax.Default
{
    public class RemoveContentTypeLinksModelNode : ListItemModelNode
    {

    }

    public static class RemoveContentTypeLinksDefinitionSyntax
    {
        #region methods

        public static TModelNode AddRemoveContentTypeLinks<TModelNode>(this TModelNode model, RemoveContentTypeLinksDefinition definition)
            where TModelNode : ModelNode, IListModelNode, new()
        {
            return AddRemoveContentTypeLinks(model, definition, null);
        }

        public static TModelNode AddRemoveContentTypeLinks<TModelNode>(this TModelNode model, RemoveContentTypeLinksDefinition definition,
            Action<HideContentTypeFieldLinksModelNode> action)
            where TModelNode : ModelNode, IListModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion
    }
}
