using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HungryGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("592a5fcb-6d75-4f48-adb1-fd9113271aa6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hungry Goblin",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c1d701d-d7fd-472f-ad06-410bd41eaf86"), Type = TextBlockType.Text, Text = "You'll eat anything and anyone. Whenever you inflict persistent bleed damage with your jaws unarmed attack, you gain temporary Hit Points equal to half your level for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5c2f29f8-8504-4c46-a41d-892b1414b795"), Feats.Instances.FangSharpener.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("948df442-5988-4f73-b63a-34107001238d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
