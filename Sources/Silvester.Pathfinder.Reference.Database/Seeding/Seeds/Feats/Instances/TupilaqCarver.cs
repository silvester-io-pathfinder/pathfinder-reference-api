using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TupilaqCarver : Template
    {
        public static readonly Guid ID = Guid.Parse("f028208a-fbd6-4b2b-9281-f02b5e0298bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tupilaq Carver",
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
            yield return new TextBlock { Id = Guid.Parse("6a5ba4d9-13db-49e5-b669-57de3df75a9b"), Type = TextBlockType.Text, Text = "~ Access: Erutaki ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("4d45fdde-cb9d-45c6-b739-2d067b19d124"), Type = TextBlockType.Text, Text = "You know the truth behind old stories that tell of sending a fetish of bone and sinew to seek vengeance. These old magics allow you to conjure constructs with ease. Add the (spell: summon construct) spell to your spell list. The constructs you summon have a distinct ivory scrimshaw appearance, and if you include a drop of blood, lock of hair, or other portion of a creature’s body as part of the spell’s material component, the summoned construct gains a +4 status bonus to Perception checks to sense or locate that creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("31a0a979-f8c6-4cfc-bb9b-75957aa0bbce"), or => 
            {
                or.HaveSpecificMagicTradition(Guid.Parse("4424e6e9-355d-498b-8511-592e790d5e06"), MagicTraditions.Instances.Divine.ID);
                or.HaveSpecificMagicTradition(Guid.Parse("f67b3cde-12bb-425e-a70f-943a1c3bdc45"), MagicTraditions.Instances.Primal.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40125ea0-9852-4b83-98df-89e0a3883ebe"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
