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
    public class GoblinWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("fe1fcfab-6fe6-4e25-9772-6e3ad7e181f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goblin Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("8f2be6f9-ecc0-4198-9a11-1dfb2db8e461"), Type = TextBlockType.Text, Text = $"Others might look upon them with disdain, but you know that the weapons of your people are as effective as they are sharp. You are trained with the dogslicer and horsechopper." };
            yield return new TextBlock { Id = Guid.Parse("92689bd0-af56-4be4-8496-d059e7227ea6"), Type = TextBlockType.Text, Text = $"In addition, you gain access to all uncommon goblin weapons. For the purpose of determining your proficiency, martial goblin weapons are simple weapons and advanced goblin weapons are martial weapons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f48b068c-2186-464b-aadc-b8cd72dd6929"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
