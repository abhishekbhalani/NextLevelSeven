﻿using NextLevelSeven.Core.Encoding;

namespace NextLevelSeven.Native.Elements
{
    /// <summary>
    ///     Represents a field that does not use a repetition delimiter (repeats are considered part of the value.)
    /// </summary>
    internal sealed class FieldParserWithoutRepetitions : FieldParser
    {
        /// <summary>
        ///     Create a field without split repetition values.
        /// </summary>
        /// <param name="ancestor">Ancestor element.</param>
        /// <param name="parentIndex">Index within the parent's raw data.</param>
        /// <param name="externalIndex">Exposed index.</param>
        public FieldParserWithoutRepetitions(ElementParser ancestor, int parentIndex, int externalIndex)
            : base(ancestor, parentIndex, externalIndex)
        {
        }

        /// <summary>
        ///     Create a detached field without split repetition values.
        /// </summary>
        /// <param name="value">Initial value.</param>
        /// <param name="config">Encoding configuration.</param>
        private FieldParserWithoutRepetitions(string value, EncodingConfigurationBase config)
            : base(value, config)
        {
        }

        /// <summary>
        ///     Delimiter is invalid for a field without repetitions.
        /// </summary>
        public override char Delimiter
        {
            get { return '\0'; }
        }

        /// <summary>
        ///     Returns 1, since all repetitions are counted as a single repetition value.
        /// </summary>
        public override int ValueCount
        {
            get { return 1; }
        }

        /// <summary>
        ///     Get the descendant repetition at the specified index.
        /// </summary>
        /// <param name="index">Desired index.</param>
        /// <returns>Descendant repetition.</returns>
        protected override RepetitionParser CreateRepetition(int index)
        {
            return new RepetitionParser(this, index - 1, index);
        }

        /// <summary>
        ///     Deep clone this field.
        /// </summary>
        /// <returns>Clone of the field.</returns>
        protected override FieldParser CloneInternal()
        {
            return new FieldParserWithoutRepetitions(Value, EncodingConfiguration) {Index = Index};
        }
    }
}