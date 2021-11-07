using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("c877d561-9ab5-4bc6-878a-2b94d75459f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Skin",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc9c6491-a569-4024-a2d6-07ebef27f2ac"), Type = TextBlockType.Text, Text = "Your proficiency in unarmored defense increases to expert. While you are raging and unarmored, your skin transforms into a thick hide resembling your animal’s skin. You gain a +1 status bonus to AC instead of taking a -1 penalty to AC; if you have the greater juggernaut class feature, this status bonus increases to +2. The thickness of your hide gives you a Dexterity modifier cap to your AC of +3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("dd9fb4b3-df73-4d2e-8202-afa543024e01"), Instincts.Instances.AnimalInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cff01c12-849c-438e-997e-c1d4f8d71837"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
