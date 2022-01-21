using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CollapseArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("a8cca3db-1381-4e7a-8456-7fcda8ba93fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Collapse Armor",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7cdb1b5a-0c87-4a83-932b-2ba2b72fa783"), Type = TextBlockType.Text, Text = $"You've modified your armor innovation to collapse into a more compact form so you can don or remove it in an instant. If you're wearing your innovation when you Collapse your Armor, you remove it instantly, and it compresses into its compact form, which is held in both of your hands (if you don't have both hands available, it falls to the ground in an adjacent space). If you're holding your armor in compact form when you take this action, it unfolds back into its armor form onto your body." };
            yield return new TextBlock { Id = Guid.Parse("312d70bf-d34c-4a9c-a06c-68987f1aa4de"), Type = TextBlockType.Text, Text = $"In compact form, your armor innovation is easier to carry, with a Bulk 1 lower than the Bulk listed for it, to a minimum of light Bulk (carried armor normally has a Bulk 1 higher than listed in the armor entry)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("dc3dbd3d-7cc5-4899-ae8e-eefaa3a3e6d7"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae531fff-df2a-44c1-bf2a-cdf7c90c156e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
