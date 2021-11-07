using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SixthPillarDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("7f325ec4-5e38-495c-9e9d-ee140d4d8883");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sixth Pillar Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the Sixth Pillar archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("16d7eefd-a0f2-4a77-bf17-61ff0510ed9f"), Type = TextBlockType.Text, Text = "You use your physical discipline to channel your magic. If your proficiency rank in unarmed attacks is at least expert, your proficiency rank in spell attacks increases to expert. Likewise, if your proficiency rank in spell attacks is at least expert, your proficiency rank in unarmed attacks improves to expert. You become an expert in Athletics, or in another trained skill if you were already expert in Athletics." };
            yield return new TextBlock { Id = Guid.Parse("2a0d262a-0fb3-48e7-9557-5ccd1443cfd0"), Type = TextBlockType.Text, Text = "__Manually improve your spell attacks and unarmed attacks proficiencies accordingly.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("5c92335c-2f95-4b41-9592-d013e767d7e2"));
            builder.HaveSpecificStat(Guid.Parse("a5ac072d-ec6f-4865-bf82-5fa5bfd0942c"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("3a641a57-57d9-444d-9846-83e350b50643"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb3f1517-bdf9-410d-b21f-9fa303316bee"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
