using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Standard.Syntax
{

    [Serializable]
    [DataContract]
    public class TagCloudWebPartModelNode : WebPartModelNode
    {

    }

    public static class TagCloudWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddTagCloudWebPart<TModelNode>(this TModelNode model, TagCloudWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddTagCloudWebPart(model, definition, null);
        }

        public static TModelNode AddTagCloudWebPart<TModelNode>(this TModelNode model, TagCloudWebPartDefinition definition,
            Action<TagCloudWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddTagCloudWebParts<TModelNode>(this TModelNode model, IEnumerable<TagCloudWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
