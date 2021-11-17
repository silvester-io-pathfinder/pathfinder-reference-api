using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MethodicalDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("a81dec8a-deca-4794-b816-c7c24e55d180");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Methodical Debilitations",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("141a141d-40a4-4fa5-bee7-e033e7729df0"), Type = TextBlockType.Text, Text = "You strategically craft your debilitations to lessen or negate an enemy’s tactical advantages. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("bd837fa1-1d7a-4a37-b11b-8295a4982526"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target can’t flank other creatures, and it can’t provide flanking for its allies." };
            yield return new TextBlock { Id = Guid.Parse("c9f003c4-6802-465e-9e2f-1da035a100a5"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target doesn’t gain a circumstance bonus to AC from Raising a Shield, lesser cover, or standard cover; it gains only a +2 circumstance bonus to AC from greater cover or (action: Taking Cover | Take Cover)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("1c682603-12cc-4ee9-952f-e7870e02b4d6"), Rackets.Instances.Mastermind.ID);
            builder.HaveSpecificFeat(Guid.Parse("074e5cd9-5849-41c4-993c-37645d9c8658"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2dd0ba91-1534-4a75-9c54-1cfd252d4d7c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
