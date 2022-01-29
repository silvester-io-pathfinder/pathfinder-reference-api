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
    public class GadgetSpecialist : Template
    {
        public static readonly Guid ID = Guid.Parse("353617c8-314b-4357-94c2-2fe9d663bc3e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gadget Specialist",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51af00f2-9e40-4463-a901-176fa69a26c8"), Type = TextBlockType.Text, Text = $"Rather than just using your gadgets for various boosts and tweaks, you also craft a few specific temporary consumable gadgets each day. You gain the formulas for three common or uncommon gadgets (G&amp;G pg. 66). Each day during your daily preparations, you can create two temporary gadgets from your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("formula book", Items.AdventuringGears.Instances.FormulaBook.ID)}. Gadgets prepared in this way don't cost you any resources to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} and don't have any sale value. They are temporary items and fall apart the next time you make your daily preparations if you haven't already used them." };
            yield return new TextBlock { Id = Guid.Parse("3fa8663c-341f-4164-89e7-2a254ab767c3"), Type = TextBlockType.Text, Text = $"If you're a master in Crafting, you can create three gadgets per day, and you gain three additional common or uncommon gadget formulas. If you're legendary in Crafting, you can create four gadgets per day, and you gain another additional three common or uncommon gadget formulas, for a total of nine." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5075331a-c82b-4668-8844-cc112c3d76d8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b714b130-bf52-4667-b3c8-f2721edf75fa"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
