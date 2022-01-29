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
    public class DeadReckoning : Template
    {
        public static readonly Guid ID = Guid.Parse("ff2866c3-6a44-4dd3-acdf-1ae5980e2676");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dead Reckoning",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fca60b0c-b2da-4cda-9a08-ef18aee3bafe"), Type = TextBlockType.Text, Text = $"You've trained yourself to maintain a strong sense of direction at all times, even when you can't use a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("compass", Items.AdventuringGears.Instances.Compass.ID)} or see the sky above. You immediately intuit which direction is north (assuming the concept of north exists at your current location)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e2f884ed-68c5-4f90-833e-c95ccb0162ca"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("7c72cb2d-f44f-4950-af0b-4348f39405a0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("aaa84f62-8ce9-4f8c-aa36-21ea815f6078"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("b9476442-b920-4ab4-9ee2-f55e48476bc2"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("3af2cca8-18d9-4289-8462-6ed013abd0dd"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76d0f914-326c-4631-9c9a-4079a0296fd6"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
