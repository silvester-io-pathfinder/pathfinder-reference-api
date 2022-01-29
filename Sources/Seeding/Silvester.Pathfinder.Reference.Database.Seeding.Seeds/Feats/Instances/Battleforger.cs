using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Battleforger : Template
    {
        public static readonly Guid ID = Guid.Parse("f9545173-627d-4501-ba8f-d9844abb9df9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battleforger",
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
            yield return new TextBlock { Id = Guid.Parse("3aca092c-1098-4c08-8db8-b2da233c1ae0"), Type = TextBlockType.Text, Text = $"You can sharpen weapons, polish armor, and apply special techniques to temporarily gain better effects from your armaments. By spending 1 hour working on a weapon or armor, you can grant it the effects of a +1 potency rune until your next daily preparations, gaining a +1 item bonus to attack rolls for a weapon or increasing armor's item bonus to AC by 1. This has no effect if the weapon or armor already had a potency rune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b1bedef9-f4a7-4fec-9685-cf5de3f11125"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b498a70-1fc5-4aa2-833e-c266e6b238c9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
