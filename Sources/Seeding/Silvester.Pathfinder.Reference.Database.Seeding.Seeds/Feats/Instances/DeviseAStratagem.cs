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
    public class DeviseAStratagem : Template
    {
        public static readonly Guid ID = Guid.Parse("ea788e30-3f9a-49e2-b5e8-189bb1da40a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devise a Stratagem",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e192575f-80d3-469a-ace2-0275cae0632e"), Type = TextBlockType.Text, Text = $"You assess a foe's weaknesses in combat and use them to formulate a plan of attack against your enemy. Choose a creature you can see and roll a d20. If you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} the chosen creature later this round, you must use the result of the roll you made to Devise a Stratagem for your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}'s attack roll instead of rolling. You make this substitution only for the first {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} you make against the creature this round, not any subsequent attacks." };
            yield return new TextBlock { Id = Guid.Parse("f2fae141-f1c2-4146-970d-1d9eee81f213"), Type = TextBlockType.Text, Text = $"When you make this substitution, you can also add your Intelligence modifier to your attack roll instead of your Strength or Dexterity modifier, provided your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} uses an {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} or {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} melee weapon, an {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} or {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} unarmed attack, a ranged weapon (which must be {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} or {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} if it's a melee weapon with the {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} trait), or a {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("sap", Items.MeleeWeapons.Instances.Sap.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("bb0a8f04-69a5-41c9-b77d-d6d0856077d6"), Type = TextBlockType.Text, Text = $"If you're aware that the creature you choose is the subject of a lead you're pursuing, you can use this ability as a free action." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8c99128-77fc-4130-8d72-0cef17327b66"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
