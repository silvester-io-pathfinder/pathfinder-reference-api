using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UrgentUpwelling : Template
    {
        public static readonly Guid ID = Guid.Parse("8f52a7fd-daae-4023-8712-550356220767");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Urgent Upwelling",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy reduces you to 0 HP, an enemy critically hits you, or you critically fail a saving throw against an enemy's effect.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6fbabef2-61c4-41cd-9bb6-a31960ef381f"), Type = TextBlockType.Text, Text = "Defeat lets you to tap into your wellspring. Attempt the flat check for wellspring magic. If you critically succeed, you can choose to forgo gaining a temporary spell slot to instead have the triggering enemy undergo a wellspring surge. This surge functions just as it would for you, the only difference being that it emits from the enemy." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d11d3886-81e6-4b74-8f1d-3a7e57507d76"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("600c541a-508d-4837-854f-c8cbff4d79ef"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
