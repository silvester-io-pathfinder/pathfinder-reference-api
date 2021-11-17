using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConrasuWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("41455c3f-203e-4dd9-acae-6513c9d1a54b");

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
            yield return new TextBlock { Id = Guid.Parse("a120ec3d-1799-42c5-8659-98656f9a1555"), Type = TextBlockType.Text, Text = "You have taken it upon yourself to learn the ways of combat to aid with your tasks, perhaps in a role as a corrector. You are trained with the (item: composite shortbow), (item: glaive), (item: longspear), (item: longsword), (item: shortbow), and (item: spear). You also gain access to all uncommon conrasu weapons. For the purpose of determining your proficiency, martial conrasu weapons are simple weapons and advanced conrasu weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7e470f2-0e11-4aa5-be11-332339895ee8"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
