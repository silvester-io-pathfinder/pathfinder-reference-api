using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalUnderstudy : Template
    {
        public static readonly Guid ID = Guid.Parse("4a509da9-eb3f-4361-83c9-e006504f3d24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Understudy",
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
            yield return new TextBlock { Id = Guid.Parse("54fd84a7-3b7d-43fa-8de2-5b36c37a29e9"), Type = TextBlockType.Text, Text = "Your eidolon evolves to cast spells. It gains the (action: Cast a Spell) activity and learns two cantrips of its tradition, which it can cast as innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f7be2f9-c98b-4803-a976-feef6dfcaaca"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
