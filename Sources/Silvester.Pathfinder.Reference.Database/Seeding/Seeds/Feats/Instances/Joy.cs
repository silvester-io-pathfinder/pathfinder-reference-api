using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Joy : Template
    {
        public static readonly Guid ID = Guid.Parse("5d8d2f49-b6ec-4893-9dfc-f79b781514ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Joy",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4eceaaa9-2fb2-44ba-83ab-c0fc3a0294ff"), Type = TextBlockType.Text, Text = "Your unbridled enthusiasm and positive attitude can lead you to success, but you might expend more energy than you planned." };
            yield return new TextBlock { Id = Guid.Parse("3e77a3db-1209-4fce-aef7-1cf12d94dd63"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: You critically succeed on an attack roll or save, or an enemy critically fails on a save against you." };
            yield return new TextBlock { Id = Guid.Parse("20edcb30-582a-494a-b1c9-91d1b131cbff"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: Reduce the value of any frightened or stupefied condition you have by 1 and end any persistent mental damage you have." };
            yield return new TextBlock { Id = Guid.Parse("80808aa1-390b-4ad6-911d-88cad5f93a66"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: You gain a +1 status bonus to Performance checks and to the spell attack rolls of emotion spells, and enemies take a –1 status penalty to saves against your emotion spells. Spell: (spell: hideous laughter)" };
            yield return new TextBlock { Id = Guid.Parse("fe0c00c1-06d5-4eda-b79c-33a1c4f6ffb7"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You become fatigued until you (feat: Settle your Emotions| Settle Emotions)." };
            yield return new TextBlock { Id = Guid.Parse("1718b686-f153-4e8c-afa8-91571d30b227"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: unimpeded stride)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0432abcc-16fa-4593-8223-224d8eaa93c4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
