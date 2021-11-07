using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoblinWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("e34d338b-e878-47fd-891d-8561d888ac28");

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
            yield return new TextBlock { Id = Guid.Parse("5cf5d03b-7fd9-4383-98b1-1eb627dc375d"), Type = TextBlockType.Text, Text = "Others might look upon them with disdain, but you know that the weapons of your people are as effective as they are sharp. You are trained with the dogslicer and horsechopper." };
            yield return new TextBlock { Id = Guid.Parse("7350928f-be94-4e54-b83c-6ad138b404e5"), Type = TextBlockType.Text, Text = "In addition, you gain access to all uncommon goblin weapons. For the purpose of determining your proficiency, martial goblin weapons are simple weapons and advanced goblin weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c5d57b4-246d-4e08-a62e-09289ad24121"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
