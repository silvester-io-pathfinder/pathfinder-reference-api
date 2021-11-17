using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("1aaccc3d-a746-48a5-8baa-f335c08aab2e");

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
            yield return new TextBlock { Id = Guid.Parse("0b7f7089-1761-4cfa-91cc-cab23505e533"), Type = TextBlockType.Text, Text = "Your proficiency in unarmored defense increases to expert. While you are raging and unarmored, your skin transforms into a thick hide resembling your animal’s skin. You gain a +1 status bonus to AC instead of taking a -1 penalty to AC; if you have the greater juggernaut class feature, this status bonus increases to +2. The thickness of your hide gives you a Dexterity modifier cap to your AC of +3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("b93520ab-54ad-4889-9431-b29049ed9ee8"), Instincts.Instances.AnimalInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("432b0feb-b0a2-4514-8678-17a7c5cb0be0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}