using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PersistentMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("e9a9373e-06c4-4903-aae7-b527a5030a61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Persistent Mutagen",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a16aa156-d21e-409a-8c1f-64ede3de0bd4"), Type = TextBlockType.Text, Text = "You’ve trained your physical form to remain stable within the a given altered state. Once per day, when you consume an alchemical item with the (trait: infused) and (trait: mutagen) traits, you can retain its effects until the next time you make your daily preparations instead of its normal duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e23dada2-2e10-49cc-a17f-7de14f227843"), Feats.Instances.ExtendElixir.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9d9a873-117d-498e-9cfd-35b466334dc1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
