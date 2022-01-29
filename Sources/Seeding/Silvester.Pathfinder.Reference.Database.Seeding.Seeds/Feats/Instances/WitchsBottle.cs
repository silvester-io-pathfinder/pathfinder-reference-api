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
    public class WitchsBottle : Template
    {
        public static readonly Guid ID = Guid.Parse("e4d7dde3-2d0d-4b75-9c64-2fc1f459fa8e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch's Bottle",
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
            yield return new TextBlock { Id = Guid.Parse("0c1805c9-5743-414f-b71f-bb6976e8ca19"), Type = TextBlockType.Text, Text = $"You spend 10 minutes and 1 Focus Point brewing a special potion containing the power of one of your hexes that targets a creature. A creature that consumes this potion is targeted by the hex. If the hex has a sustained duration and you have {ToMarkdownLink<Models.Entities.Spell>("cackle", Spells.Instances.Cackle.ID)}, you can cast {ToMarkdownLink<Models.Entities.Spell>("cackle", Spells.Instances.Cackle.ID)} into the bottle just before you seal it. If you do, the hex's duration is extended as if you had cast {ToMarkdownLink<Models.Entities.Spell>("cackle", Spells.Instances.Cackle.ID)} the round after the hex was cast (typically this extends the duration by 1 round). Your cackling laugh sounds out when the potion is unsealed." };
            yield return new TextBlock { Id = Guid.Parse("e8b1b837-abfa-4c92-bafa-04c104cedf20"), Type = TextBlockType.Text, Text = $"Any potion you create this way loses its power the next time you make your daily preparations. While the potion is in your possession, you can render it inert using a single action that has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. You can't regain the Focus Point you spent to create the potion (or the Focus Point you spent to cast {ToMarkdownLink<Models.Entities.Spell>("cackle", Spells.Instances.Cackle.ID)}) until the potion is consumed or loses its magic." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e21e0fef-c42a-42d2-a8b9-00a5877a8c83"), Feats.Instances.Cauldron.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5f81890d-82a7-4aad-9cfb-869b6d7ccd8f"), Traits.Instances.Witch.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb9dbf64-84f1-4a4d-a251-b6298e1155ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
