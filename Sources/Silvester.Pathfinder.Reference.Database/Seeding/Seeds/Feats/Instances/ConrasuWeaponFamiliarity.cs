using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConrasuWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("fa5cf965-dff7-47d4-8980-349872b51e61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conrasu Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("ee65657e-43fc-4d74-a510-9ee5f7f45d4d"), Type = TextBlockType.Text, Text = "You have taken it upon yourself to learn the ways of combat to aid with your tasks, perhaps in a role as a corrector. You are trained with the (item: composite shortbow), (item: glaive), (item: longspear), (item: longsword), (item: shortbow), and (item: spear). You also gain access to all uncommon conrasu weapons. For the purpose of determining your proficiency, martial conrasu weapons are simple weapons and advanced conrasu weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7470ca95-be6d-49d1-945b-e29fbc22012a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
