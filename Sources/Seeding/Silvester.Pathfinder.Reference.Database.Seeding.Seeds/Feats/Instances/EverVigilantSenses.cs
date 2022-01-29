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
    public class EverVigilantSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("639fbebc-38f2-4609-af48-03a82786b83f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ever-Vigilant Senses",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3cc297b-0f94-4e77-9248-59d7472ebdd5"), Type = TextBlockType.Text, Text = $"Your eidolon has enhanced senses. It gains a +2 circumstance bonus to Perception, and can't be flanked except by creatures that are higher level than it. It can see invisible creatures and objects; they appear translucent and are concealed. When your eidolon moves within 30 feet of an illusion that can be disbelieved, the GM rolls a secret check to disbelieve it, even if your eidolon didn't spend an action to {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bbf93be7-22f1-4906-9b0b-468cb4f1d28c"), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse("657ea91d-ff89-4cad-adcc-e014c2aaa6ec"), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5e7da1c-597d-4d48-ab62-35224320b3ad"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
