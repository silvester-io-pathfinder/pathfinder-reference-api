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
    public class MagicalAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("787504c8-33ad-4f91-87a6-21342b5622b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Adept",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ddd0c65-f8e1-4e2d-a7ba-0ea36d23054a"), Type = TextBlockType.Text, Text = $"Your eidolon gains more magic. Choose one 2nd-level spell and one 1st-level spell of your eidolon's tradition. Your eidolon can cast them each once per day as innate spells. At every even level after you take this feat, your eidolon can swap one of these innate spells for a new innate spell that's 2 or more levels lower than your highest-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("11f5682a-30fd-4d31-ad96-67a31d891550"), Feats.Instances.MagicalUnderstudy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9b0e52a5-73dc-41bf-987a-b8ca8e9456aa"), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse("8cd7217a-4c46-465b-9cc9-d9fb95472dc6"), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fb2f98e-6ac4-4fcc-8e0d-ccdc2d9104be"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
