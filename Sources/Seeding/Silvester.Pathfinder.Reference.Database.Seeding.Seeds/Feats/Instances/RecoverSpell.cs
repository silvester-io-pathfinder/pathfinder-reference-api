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
    public class RecoverSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("af845c16-3db6-47f8-a18e-7886af67e58d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recover Spell",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d8e619b-9b70-4d8c-9ba8-5ba8bf7a307f"), Type = TextBlockType.Text, Text = $"You recover the energy of a recently disrupted spell, allowing you to cast it again as long as you do so immediately before the energy dissipates. You regain the use of a spell that was disrupted since the beginning of your last turn, but you must immediately {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)} again with your next action or else you lose the spell; as normal for {ToMarkdownLink<Models.Entities.Trait>("metamagic", Traits.Instances.Metamagic.ID)}, this must be on the same turn that you use Recover Spell. You can change the area, targets, and other variables, including the number of actions used to {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)} if the spell allows, such as when casting {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} or {ToMarkdownLink<Models.Entities.Spell>("magic missile", Spells.Instances.MagicMissile.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("09a79777-a7c1-4e03-b865-d5874f31dc9c"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("30986dee-f442-4dc1-9978-aa407852e748"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("a43e9daf-1de1-458d-b18c-1c71a1f349bc"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("458accc5-e5a4-4650-ac7a-864197767a11"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa71de79-fa1f-43dd-a2b5-079e63182a12"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
