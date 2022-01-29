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
    public class ReachSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("842ed8e0-28ca-4608-b76f-58dd3e234fe3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach Spell",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f12c8335-ce2b-4cc3-a9bb-52636bcfa9bc"), Type = TextBlockType.Text, Text = $"You can extend the range of your spells. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that has a range, increase that spell's range by 30 feet. As is standard for increasing spell ranges, if the spell normally has a range of touch, you extend its range to 30 feet." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("82cd481a-5e66-45aa-b740-f58b52878f6e"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("375cc428-c6f3-4d14-8274-e75684304f14"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("c1de254b-5e2b-46c3-bf03-c1c039a70ac0"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("95b9bfcd-eaad-49e5-b9cd-5a73c2454889"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("dfca3f11-8f2b-4055-968a-22d120dbf24f"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("c2f58f17-33ee-4e3d-a9c6-41df79fc2510"), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse("2387f1f6-741f-46a9-82e4-e10bad9a7544"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("54afc2b6-3b6c-43e3-99fe-8a3da97507df"), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse("93df8cf5-4907-4330-81f7-404a1f764a28"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2025c91a-79d8-4d81-9c1d-944574c5ed29"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
