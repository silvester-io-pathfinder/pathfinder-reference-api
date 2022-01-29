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
    public class FlexibleSpellcasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d8a2280e-b3c1-48ff-8d53-0fb18a62015b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flexible Spellcaster Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fdbe1cd4-3c29-483f-82f1-f0afe497e97e"), Type = TextBlockType.Text, Text = $"You now have four cantrips per day instead of three. At 4th level, you have five cantrips per day instead of four." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("72e61ed1-2ce4-481e-8380-5226adae8f9f"), "Flexible spell preparation.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("17bb3f76-1a00-4583-bffe-c567c8925925"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("6cc49181-fd7c-4866-99b5-0e3b87a83897"), Traits.Instances.Class.ID);
            builder.Add(Guid.Parse("21fac86d-d243-4aa1-aa96-c501204f7af1"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a1c568a-b88d-4f6c-9c72-e5f87d7f3937"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
