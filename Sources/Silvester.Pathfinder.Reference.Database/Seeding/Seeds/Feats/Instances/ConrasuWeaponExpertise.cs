using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConrasuWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("c57f5e4e-02a9-4d69-81e5-4f48b3311bbf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conrasu Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2eac50d1-41b3-4990-bf86-186b43d8625b"), Type = TextBlockType.Text, Text = "Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency for (item: composite shortbow), (item: glaive), (item: longspear), (item: longsword), (item: shortbow), (item: spear), and all conrasu weapons in which you are trained." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6efcb11f-3110-4406-92f1-2f520656579c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
