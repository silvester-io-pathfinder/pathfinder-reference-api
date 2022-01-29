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
    public class DefensiveCoordination : Template
    {
        public static readonly Guid ID = Guid.Parse("4b6f31c7-e2d4-42d0-a011-185369a2d844");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Coordination",
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
            yield return new TextBlock { Id = Guid.Parse("e0ad7213-ad30-4ee8-8d2b-12cbe623b661"), Type = TextBlockType.Text, Text = $"Like the storied heroes who persist in the face of overwhelming odds, you and your allies will hold the line. If your next action is to cast the {ToMarkdownLink<Models.Entities.Spell>("inspire defense", Spells.Instances.InspireDefense.ID)} composition cantrip, you can {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)}, and one ally who gains a status bonus from the spell can immediately use a reaction to {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("3ba62780-174c-493f-83cc-fe3f372197e8"), Muses.Instances.Warrior.ID);
            builder.HaveSpecificFeat(Guid.Parse("750ea05b-3dd6-4c93-9848-f2f258ba50c0"), Feats.Instances.InspireDefense.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0d95c727-3443-4385-9b0d-2b840b9346bc"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("29d5c22f-881f-4274-8b8f-2d7a48f49044"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("5386da6f-001a-4736-bd68-8c04b5994f4c"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("19948cc8-4c07-4e4d-ba7d-533744aa2cd1"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec890fe1-47a6-4448-88cb-4089659b5f77"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
