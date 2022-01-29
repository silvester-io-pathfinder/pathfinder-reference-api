using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationIncredibleResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("7d8e03a7-0c0f-4bbb-9311-e663050da504");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Incredible Resistance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f50ef36-8862-4cc8-865f-044ac92fb8e0"), Type = TextBlockType.Text, Text = $"You've improved upon your breakthrough modification's ability to resist damage. Choose one of the following breakthrough modifications your innovation has: {ToMarkdownLink<Models.Entities.Feat>("dense plating", Feats.Instances.ModificationDensePlating.ID)}, {ToMarkdownLink<Models.Entities.Feat>("layered mesh", Feats.Instances.ModificationLayeredMesh.ID)}, or {ToMarkdownLink<Models.Entities.Feat>("tensile absorption", Feats.Instances.ModificationTensileAbsorption.ID)}. Increase the resistance you gain from that modification to be equal to your level, instead of half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ca8f646-43c0-4941-a3db-3d7b5754edba"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
