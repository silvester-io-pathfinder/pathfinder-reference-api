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
    public class NosoisMask : Template
    {
        public static readonly Guid ID = Guid.Parse("8938ca45-aa5f-4b7d-9628-b63c32d00e9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nosoi's Mask",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87f5ae44-2d5c-4339-9679-c8edd97c19aa"), Type = TextBlockType.Text, Text = $"Many psychopomps wear masks when dealing with the living, and many cultures believe that seeing an unmasked psychopomp's face invites death. You are trained in Intimidation and gain the {ToMarkdownLink<Models.Entities.Feat>("Intimidating Glare", Feats.Instances.IntimidatingGlare.ID)} skill feat. If you were already trained in Intimidation (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("08b17cde-b22f-4382-994e-3fd07578b594"), Type = TextBlockType.Text, Text = $"You also know how to make masks like those worn by psychopomps, a process that takes 1 hour and 1 sp of appropriate material. If you instead pay 50 gp for a splendid {ToMarkdownLink<Models.Items.Instances.WornItem>("psychopomp mask", Items.WornItems.Instances.PsychopompMask.ID)} (splendid), the mask grants you a +1 item bonus to Intimidation while you are wearing it. Its usage is worn (mask)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bedc6919-5375-4e67-90ba-22a7d9f64cb6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4bdc9eb5-1926-4a1b-ada1-19c0c1957de0"), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b653972c-3998-437a-8d37-d351ed9e8666"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
