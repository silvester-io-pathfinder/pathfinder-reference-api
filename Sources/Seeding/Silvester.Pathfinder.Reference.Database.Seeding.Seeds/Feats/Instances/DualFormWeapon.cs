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
    public class DualFormWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("3242b13d-9d45-4514-bdb2-342637e2208d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual-Form Weapon",
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
            yield return new TextBlock { Id = Guid.Parse("27caa6ba-0da8-458f-85fc-43049a84d9a7"), Type = TextBlockType.Text, Text = $"You've built your innovation with replaceable interlocking pieces that you can use to transform it into another type of weapon entirely. When you select this feat, choose a level 0 or 1st-level simple or martial weapon. It must be either a common weapon or another to which you have access. This weapon becomes your innovation's second configuration." };
            yield return new TextBlock { Id = Guid.Parse("9438b2db-bf3f-4ef8-8005-25b41ea37b8f"), Type = TextBlockType.Text, Text = $"Select a new set of weapon modifications for this new configuration. You can spend two {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions to switch your weapon innovation between the two configurations. These actions don't need to be taken consecutively, but if you've provided the first and not the second, the weapon is non-functional as it is stranded between states. Your weapon's Bulk is always the greater Bulk of the two configurations, regardless of which configuration it's in—if one weapon is smaller than the other, you still need to keep any weapon parts on hand. Any runes on your weapon innovation don't affect the second weapon configuration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("c4b7909c-d8eb-4b3b-bea2-d2d75fc628d8"), Innovations.Instances.Weapon.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f03e0e73-39b8-4a0b-b67d-9bda7a5f6037"), Traits.Instances.Inventor.ID);
            builder.Add(Guid.Parse("29e4b2d2-e334-41bb-99aa-db4d372944fc"), Traits.Instances.Modification.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a97b84ee-608b-4296-b528-6d5cd0d9df83"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
