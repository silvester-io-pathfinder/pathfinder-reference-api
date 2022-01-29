using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmiteGood : Template
    {
        public static readonly Guid ID = Guid.Parse("ec4e2874-2954-4602-979d-6dfd2f16fafa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smite Good",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("78dbc110-1a17-44d0-8c4a-66482d3ae3b2"), Type = TextBlockType.Text, Text = $"Your blade ally shares your lust for the blood of good creatures. Select one enemy you can see. Until the start of your next turn, your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against that foe using the weapon your blade ally inhabits deal an extra 4 evil damage, increasing to 6 if you have master proficiency with this weapon." };
            yield return new TextBlock { Id = Guid.Parse("635e13fb-46b9-493a-96ed-c42fa1d42a6c"), Type = TextBlockType.Text, Text = $"If the chosen enemy attacks you before the start of your next turn, the duration extends to the end of that enemy's next turn. If the enemy continues to attack you each turn, the duration continues to extend." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("045c4350-c63e-4833-85eb-eaf64073eb97"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("561c1701-d129-4ba5-8c4a-efcad537a66e"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0416ca2e-73c3-4e4c-a1f0-b5632b65ff34"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
