using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMomentumRetainer : Template
    {
        public static readonly Guid ID = Guid.Parse("c7e3d58c-caac-456a-b042-c8cce840ffe9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Momentum Retainer",
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
            yield return new TextBlock { Id = Guid.Parse("3e827027-d699-46e0-86bb-9e538b175064"), Type = TextBlockType.Enumeration, Text = "*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("62fc82e5-81c0-4e28-8c89-964aa2125054"), Type = TextBlockType.Text, Text = "A special weighted device lets your weapon retain more of its momentum when you attack. Your innovation gains the (trait: forceful) and (trait: versatile B) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35ad6d0e-d03c-4b00-b865-405e0751eb5b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
